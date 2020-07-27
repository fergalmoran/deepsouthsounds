#!/usr/bin/env bash
docker run \
    --name dss-pgsql \
    --restart always \
    -p 5432:5432 \
    -e "POSTGRES_PASSWORD=H8ckMyB88lz" \
    -e "PGDATA=/var/lib/postgresql/data/pgdata" \
    -v /opt/postgres:/var/lib/postgresql/data \
    -d postgres:9.6.18
