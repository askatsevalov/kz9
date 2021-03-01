FROM node:12.7-alpine AS build-env

WORKDIR /app

COPY package.json yarn.lock ./

# RUN npm install --loglevel=error
RUN yarn install

COPY . .

RUN npm run build

FROM nginx:stable-alpine

COPY nginx.conf /temp/nginx.conf

RUN envsubst /app < /temp/nginx.conf > /etc/nginx/conf.d/default.conf

COPY --from=build-env /app/dist /usr/share/nginx/html

EXPOSE 80